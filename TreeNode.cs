using System;
using System.Collections;
using System.Collections.Generic;
namespace enum_classes
{

    public class DependencyNode<T> :  TreeNode<T>
    {
        public DependencyNode(T x) : base(x){ }

        public DependencyNode<T> Then(DependencyNode<T> next){
            Children.Add(next);
            return this;
        }
    }
    public class TreeNode<T> 
    {
        public T Value;
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();
        public TreeNode(T x) { Value = x; }
    }
}

