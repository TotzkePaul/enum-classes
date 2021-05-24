using System;
using System.Collections;
using System.Collections.Generic;

namespace enum_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new DependencyNode<AnimalType>(AnimalType.Cat);
            var dog = new DependencyNode<AnimalType>(AnimalType.Dog);
            var wolf = new DependencyNode<AnimalType>(AnimalType.Wolf);
            var mouse = new DependencyNode<AnimalType>(AnimalType.Mouse);
            var bird = new DependencyNode<AnimalType>(AnimalType.Bird);

            Action<TreeNode<AnimalType>> close = (TreeNode<AnimalType> node) => {
                Console.WriteLine($"Closing {node.Value} ");
                Console.WriteLine($"Get {node.Value.Get}/{node.Value.FamilyId}");
                Console.WriteLine($"Post {node.Value.Post}/{node.Value.OrderId}");
            };

            Action<TreeNode<AnimalType>> betaJob = (TreeNode<AnimalType> node) => {
                Queue<TreeNode<AnimalType>> q = new Queue<TreeNode<AnimalType>>();
                q.Enqueue(node);
                while(q.Count > 0){
                    var current = q.Dequeue();
                    close(current);
                    current.Children.ForEach(child => q.Enqueue(child));
                }
            };

            var hierarchy  = wolf
                            .Then(dog)
                            .Then(
                                cat
                                    .Then(mouse)
                                    .Then(bird));

            Console.WriteLine("Print Tree:");
            PrintTree(hierarchy, "", true);
            Console.WriteLine("---------");

            betaJob(wolf);
        }


        static void PrintTree<T>(TreeNode<T> tree, string indent, bool last)
        {
            Console.WriteLine(indent + "+- " + tree.Value);
            indent += last ? "   " : "|  ";

            for (int i = 0; i < tree.Children.Count; i++)
            {
                PrintTree(tree.Children[i], indent, i == tree.Children.Count - 1);
            }
        }
    }
}
