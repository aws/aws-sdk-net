using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public class StatusConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value)
        {
            Status status = (Status)value;
            return new Primitive(status.ToString());
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            Primitive primitive = entry.AsPrimitive();
            string text = primitive.AsString();
            Status status = (Status)Enum.Parse(typeof(Status), text);
            return status;
        }
    }

    public class DateTimeUtcConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value) => (DateTime)value;

        public object FromEntry(DynamoDBEntry entry)
        {
            var dateTime = entry.AsDateTime();
            return dateTime.ToUniversalTime();
        }
    }

    public class EnumAsStringConverter<T> : IPropertyConverter where T : struct
    {
        public DynamoDBEntry ToEntry(object value)
        {
            return new Primitive(value.ToString());
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            return Enum.Parse(typeof(T), entry.AsString());
        }
    }

    public class NameTypeLowerCaseConverter<T> : IPropertyConverter where T : NameType
    {
        public DynamoDBEntry ToEntry(object value)
        {
            var nameType = (NameType)value;
            return new Document(new Dictionary<string, DynamoDBEntry>()
            {
                { "FirstName",nameType.FirstName.ToLower() },
                { "MiddleName",nameType.MiddleName.ToLower() },
                { "LastName",nameType.LastName.ToLower() }
            });
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            var document = entry as Document;
            return new NameType
            {
                FirstName = document["FirstName"].AsString().ToLower(),
                MiddleName = document["MiddleName"].AsString().ToLower(),
                LastName = document["LastName"].AsString().ToLower(),
            };
        }
    }

    public class NameTypeUpperCaseConverter<T> : IPropertyConverter where T : NameType
    {
        public DynamoDBEntry ToEntry(object value)
        {
            var nameType = (NameType)value;
            return new Document(new Dictionary<string, DynamoDBEntry>()
            {
                { "FirstName",nameType.FirstName.ToUpper() },
                { "MiddleName",nameType.MiddleName.ToUpper() },
                { "LastName",nameType.LastName.ToUpper() }
            });
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            var document = entry as Document;
            return new NameType
            {
                FirstName = document["FirstName"].AsString().ToUpper(),
                MiddleName = document["MiddleName"].AsString().ToUpper(),
                LastName = document["LastName"].AsString().ToUpper(),
            };
        }
    }
}
