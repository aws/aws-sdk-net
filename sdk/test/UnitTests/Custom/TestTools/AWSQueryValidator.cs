using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ServiceClientGenerator;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public class AWSQueryValidator
    {
        public AWSQueryValidator(IDictionary<string, string> paramters, object request, ServiceModel serviceModel, Operation operation)
        {
            this.Parameters = paramters;
            this.Request = request;
            this.Model = serviceModel;
            this.Operation = operation;
        }

        IDictionary<string, string> Parameters { get; set; }
        object Request { get; set; }
        ServiceModel Model { get; set; }
        Operation Operation { get; set; }

        public void Validate()
        {
            Assert.AreEqual(this.Parameters["Action"], Operation.Name);
            Assert.AreEqual(this.Parameters["Version"], this.Model.APIVersion);

            Validate("", this.Request, this.Operation.RequestStructure);
        }

        public void Validate(string parameterBase, object owningObject, Shape shape)
        {
            var owningType = owningObject.GetType();
            foreach (var info in owningType.GetProperties())
            {
                if (info.SetMethod == null || info.Name == "ContentLength")
                    continue;

                var member = shape.Members.FirstOrDefault(x => x.PropertyName == info.Name);
                // Not a modeled property so skip
                if (member == null)
                    continue;

                // auto-generated code to marshall wasn't used. skip
                if (GeneratorHelpers.UseCustomMarshall(member, this.Operation))
                    continue;

                var type = info.PropertyType;
                var propertyValue = info.GetMethod.Invoke(owningObject, new object[] { });

                ValidateProperty(parameterBase, type, propertyValue, info.Name, member);
            }
        }

        private void ValidateProperty(string parameterBase, Type type, object propertyValue, string propertyName, Member member)
        {
            if (IsScalarValue(type))
            {
                var key = parameterBase;
                if (!string.IsNullOrEmpty(key))
                    key += ".";

                key += GeneratorHelpers.DetermineAWSQueryMarshallName(member, this.Operation);

                Assert.IsTrue(this.Parameters.ContainsKey(key), "Failed to find query key " + key);
            }
            else
            {
                if (type.GetInterface("System.Collections.IList") != null)
                {
                    var list = propertyValue as System.Collections.IList;
                    for (var i = 0; i < list.Count; i++)
                    {
                        var item = list[i];
                        var queryKey = ConstructMemberQueryKey(parameterBase, member, i+1);
                        if (IsScalarValue(item.GetType()))
                        {
                            Assert.IsTrue(this.Parameters.ContainsKey(queryKey), "Failed to find query key " + queryKey);
                        }
                        else
                        {
                            Validate(queryKey, item, member.Shape.ListShape);
                        }
                    }
                }
                else if (type.GetInterface("System.Collections.IDictionary") != null)
                {
                    var map = propertyValue as System.Collections.IDictionary;
                    var i = 1;
                    foreach (var key in map.Keys)
                    {
                        object value = map[key];
                        var queryKey = ConstructMemberQueryKey(parameterBase, member, i);

                        Assert.IsTrue(this.Parameters.ContainsKey(queryKey + "." + member.Shape.KeyMarshallName), "Failed to find query key " + queryKey + "." + member.Shape.KeyMarshallName);

                        if (IsScalarValue(value.GetType()))
                        {
                            Assert.IsTrue(this.Parameters.ContainsKey(queryKey + "." + member.Shape.ValueMarshallName), "Failed to find query key " + queryKey + "." + member.Shape.ValueMarshallName);
                        }
                        else
                        {
                            Validate(queryKey + "." + member.Shape.ValueMarshallName, value, member.Shape.ValueShape);
                        }

                        i++;
                    }
                    
                }
                else
                {
                    var key = parameterBase;
                    if (!string.IsNullOrEmpty(key))
                        key += ".";

                    key += GeneratorHelpers.DetermineAWSQueryMarshallName(member, this.Operation);

                    Validate(key, propertyValue, member.Shape);
                }
            }
        }

        private bool IsScalarValue(Type type)
        {
            if (type == typeof(string) ||
                type == typeof(bool) ||
                type == typeof(int) ||
                type == typeof(long) ||
                type == typeof(double) ||
                type.BaseType.FullName == "Amazon.Runtime.ConstantClass" ||
                type == typeof(DateTime))
            {
                return true;
            }

            return false;
        }

        private string ConstructMemberQueryKey(string parameterBase, Member member, int memberIndex)
        {
            var queryKey = new StringBuilder(parameterBase);
            if (queryKey.Length > 0)
                queryKey.Append(".");

            queryKey.AppendFormat("{0}.", GeneratorHelpers.DetermineAWSQueryMarshallName(member, this.Operation));
            var memberPrefix = GeneratorHelpers.DetermineAWSQueryListMemberPrefix(member); // can return empty for EC2/AWSQuery
            if (!string.IsNullOrEmpty(memberPrefix))
                queryKey.AppendFormat("{0}.", memberPrefix);
            queryKey.Append(memberIndex);

            var memberSuffix = GeneratorHelpers.DetermineAWSQueryListMemberSuffix(this.Operation, member);
            if (memberSuffix != null)
                queryKey.AppendFormat(".{0}", memberSuffix);

            return queryKey.ToString();
        }
    }
}
