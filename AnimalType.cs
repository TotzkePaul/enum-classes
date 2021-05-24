using System;
using System.Collections;
using System.Collections.Generic;

namespace enum_classes
{
    public class AnimalType : Enumeration
    {
        public static AnimalType Cat = new AnimalType(1, nameof(Cat)) { 
            OrderId = 224,
            FamilyId = 424,
            Get = "/v1/Animal/Cat_Get", 
            Post= "/v1/Animal/Cat_Post",             
            };
        public static AnimalType Dog = new AnimalType(2, nameof(Dog)){ 
            OrderId = 285,
            FamilyId = 485,
            Get = "/v1/Animal/Dog_Get", 
            Post= "/v1/Animal/Dog_Post"        
            };
        public static AnimalType Wolf = new AnimalType(3, nameof(Wolf)){ 
            OrderId = 249,
            FamilyId = 449,
            Get = "/v1/Animal/Wolf_Get", 
            Post= "/v1/Animal/Wolf_Post",             
            };

        public static AnimalType Mouse = new AnimalType(4, nameof(Mouse)){ 
            OrderId = 248,
            FamilyId = 448,
            Get = "/v1/Animal/Mouse_Get", 
            Post= "/v1/Animal/Mouse_Post",             
            };

        public static AnimalType Bird = new AnimalType(4, nameof(Bird)){ 
            OrderId = 223,
            FamilyId = 423,
            Get = "/v1/Account/Bird_Get", 
            Post= "/v1/Account/Bird_Post",             
            };

            
        public string Get {get;set;}
        public string Post {get;set;}
        public int OrderId {get;set;}
        public int FamilyId {get;set;}
        public string Species => Name.ToUpper();
        protected AnimalType(int id, string name) : base(id, name) { }
    }
}