using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [DynamoDBPolymorphicType("B1", typeof(B))]
    [DynamoDBPolymorphicType("C", typeof(C))]
    public class A
    {
        public string Name { get; set; }

        public int MyPropA { get; set; }
    }

    public interface IInterface
    {
        string S1 { get; set; }
        int S2 { get; set; }
    }

    public class InterfaceA : IInterface
    {
        public string S1 { get; set; }
        public int S2 { get; set; }

        public int S3 { get; set; }
    }

    public class InterfaceB : IInterface
    {
        public string S1 { get; set; }
        public int S2 { get; set; }
        public string S4 { get; set; }
    }

    public class B : A
    {
        public int MyPropB { get; set; }
    }

    public class C : A
    {
        public string MyPropC { get; set; }
    }

    [DynamoDBTable("NestedTable")]
    [DynamoDBPolymorphicType("A1", typeof(ModelA1))]
    [DynamoDBPolymorphicType("A2", typeof(ModelA2))]
    public class ModelA
    {
        [DynamoDBHashKey] public Guid Id { get; set; }

        public A MyType { get; set; }

        [DynamoDBPolymorphicType("I1", typeof(InterfaceA))]
        [DynamoDBPolymorphicType("I2", typeof(InterfaceB))]
        public IInterface MyInterface { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
        public string CompanyName { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
        public int Price { get; set; }

        [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex", AttributeName = "Manager")]
        public string ManagerName { get; set; }

        [DynamoDBFlatten] public Address FlatAddress { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class ModelA1 : ModelA
    {
        [DynamoDBPolymorphicType("B", typeof(B))]
        public new A MyType { get; set; }

        [DynamoDBPolymorphicType("B", typeof(B))]
        [DynamoDBProperty("test")]
        public List<A> MyClasses { get; set; }
    }

    public class ModelA2 : ModelA
    {
        [DynamoDBPolymorphicType("B", typeof(B))]
        public Dictionary<string, A> DictionaryClasses { get; set; }
    }
}
