using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.LitJson;

namespace ServiceClientGenerator
{
    public static class GeneratorHelpers
    {
        public static string DetermineSigner(string signatureVersion, string serviceBasename)
        {
            switch (signatureVersion)
            {
                case "v2":
                    return "QueryStringSigner";
                case "v3https":
                    return "AWS3Signer";
                case "v4":
                    return "AWS4Signer";
                case "s3":
                    return "Amazon.S3.Internal.S3Signer";
                case "":
                    return "NullSigner";
                default:
                    throw new Exception("Unknown signer: " + signatureVersion);
            }
        }


        private static readonly DateTime EPOCH_START = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static int ConvertToUnixEpochSeconds(DateTime dateTime)
        {
            return (int)ConvertToUnixEpochMilliSeconds(dateTime);
        }

        public static double ConvertToUnixEpochMilliSeconds(DateTime dateTime)
        {
            TimeSpan ts = new TimeSpan(dateTime.ToUniversalTime().Ticks - EPOCH_START.Ticks);
            double milli = Math.Round(ts.TotalMilliseconds, 0) / 1000.0;
            return milli;
        }

        // List members in EC2 are always considered flattened, so we drop the 'member' prefix
        public static string DetermineAWSQueryListMemberPrefix(Member member)
        {
            if (member.model.IsEC2Protocol || member.Shape.IsFlattened)
                return string.Empty;

            if (member.Shape.IsList)
                return "member";

            if (member.Shape.IsMap)
                return "entry";

            throw new Exception("Unknown member type for list member prefix determination");
        }

        /// <summary>
        /// Inspects list member to determine if the original list shape in the model has been
        /// substituted and if so, whether a member suffix should be used to extract the value
        /// for use in the query. An example usage would be the replacement of IpRange (in EC2)
        /// within an IpRangeList - we treat as a list of strings, yet need to get to the 
        /// IpRange.CidrIp member in the query marshalling. Note that we also have some EC2 
        /// operations where we don't want this submember extraction too even though the
        /// same substitite is in use.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static string DetermineAWSQueryListMemberSuffix(Operation operation, Member member)
        {
            if (member.Shape.ModelListShape == null)
                return null;

            string suffixMember = null;
            var substituteShapeData = member.model.Customizations.GetSubstituteShapeData(member.ModelShape.ModelListShape.Name);
            if (substituteShapeData != null && substituteShapeData[CustomizationsModel.EmitFromMemberKey] != null)
            {
                var useSuffix = true;
                if (substituteShapeData[CustomizationsModel.ListMemberSuffixExclusionsKey] != null)
                {
                    var exclusions = substituteShapeData[CustomizationsModel.ListMemberSuffixExclusionsKey];
                    foreach (JsonData excl in exclusions)
                    {
                        if (string.Equals(operation.Name, (string)excl, StringComparison.Ordinal))
                        {
                            useSuffix = false;
                            break;
                        }
                    }
                }

                if (useSuffix)
                    suffixMember = (string)substituteShapeData[CustomizationsModel.EmitFromMemberKey];
            }

            return suffixMember;
        }

        /// <summary>
        /// Determines if a property modifier for the member is suppressing automatic marshall
        /// generation code for the field. If true, custom code in the pipeline will handle the
        /// member.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static bool UseCustomMarshall(Member member, Operation operation)
        {
            if (member.PropertyModifier != null && member.PropertyModifier.IsSetUseCustomMarshall)
                return member.PropertyModifier.UseCustomMarshall;

            if (member.PropertyInjector != null && member.PropertyInjector.IsSetUseCustomMarshall)
                return member.PropertyInjector.UseCustomMarshall;

            return false;
        }

        // The marshal name must always be up-cased (first letter only) when used with EC2's
        // variant of AWSQuery. We can also apply operation-specific customizations for marshal
        // names
        public static string DetermineAWSQueryMarshallName(Member member, Operation operation)
        {
            var isEC2Protocol = member.model.IsEC2Protocol;
            CustomizationsModel.OperationModifiers modifiers = null;
            if (operation != null)
                modifiers = operation.OperationModifiers;

            var marshallName = new StringBuilder();
            if (modifiers != null)
            {
                var marshallOverride = modifiers.GetMarshallNameOverrides(member.OwningShape.Name, member.PropertyName);
                if (marshallOverride != null)
                {
                    var marshallOverrideName = !isEC2Protocol
                                                    ? marshallOverride.MarshallName
                                                    : (string.IsNullOrEmpty(marshallOverride.MarshallLocationName)
                                                        ? marshallOverride.MarshallName
                                                        : marshallOverride.MarshallLocationName);

                    marshallName.Append(TransformMarshallLocationName(isEC2Protocol, marshallOverrideName));
                }
            }

            // if the operation didn't override the marshal location, is there a property modifier doing so?
            if (marshallName.Length == 0 && member.PropertyModifier != null)
            {
                var locationName = TransformMarshallLocationName(isEC2Protocol, member.PropertyModifier.LocationName);
                marshallName.Append(locationName);
            }

            // if the marshal name still isn't set, fall back to the model
            if (marshallName.Length == 0)
            {
                var modelMarshallName = !isEC2Protocol
                                            ? member.MarshallName
                                            : (string.IsNullOrEmpty(member.MarshallLocationName)
                                                ? member.MarshallName
                                                : member.MarshallLocationName);

                marshallName.Append(TransformMarshallLocationName(isEC2Protocol, modelMarshallName));
            }

            // also check if we need to emit from a submember as a result of shape substitution
            var substituteShapeData = member.model.Customizations.GetSubstituteShapeData(member.ModelShape.Name);
            if (substituteShapeData != null && substituteShapeData[CustomizationsModel.EmitFromMemberKey] != null)
            {
                var valueMember = (string) substituteShapeData[CustomizationsModel.EmitFromMemberKey];
                var subMember = member.ModelShape.Members.Single(m => m.PropertyName.Equals(valueMember, StringComparison.Ordinal));
                if (subMember != null)
                {
                    var subExpression = string.IsNullOrEmpty(subMember.MarshallLocationName)
                        ? subMember.MarshallName
                        : subMember.MarshallLocationName;

                    marshallName.AppendFormat(".{0}", TransformMarshallLocationName(isEC2Protocol, subExpression));
                }
            }

            return marshallName.ToString();
        }

        // The "locationName" must always be lower-cased (first letter only) when used with EC2's
        // variant of AWSQuery. MarshallLocationName isn't consistently set.
        public static string DetermineAWSQueryBaseUnmarshallName(Member member)
        {
            if (!member.model.IsEC2Protocol)
                return member.MarshallName;

            var baseExpression = string.IsNullOrEmpty(member.MarshallLocationName)
                ? member.MarshallName
                : member.MarshallLocationName;

            return TransformUnmarshallLocationName(true, baseExpression);
        }

        // returns the unmarshall expression for a member
        public static string DetermineAWSQueryTestExpression(Member member)
        {
            var isEC2Protocol = member.model.IsEC2Protocol;
            var testExpression = DetermineAWSQueryBaseUnmarshallName(member);
            if (member.IsList)
            {
                if (!member.Shape.IsFlattened)
                {
                    testExpression += "/";
                    if (member.Shape.ListMarshallName != null)
                        testExpression += member.Shape.ListMarshallName;
                    else
                        testExpression += "member";

                    // If the list element shape has a customization replacing it
                    // with another shape, extend the expression with any subexpression
                    // to the value member that the replaced shape has. This allows us to 
                    // handle collections of EC2's AttributeValue shape which is replaced 
                    // by a 'string' and we unmarshall the collection using the shape's 'value' 
                    // member.
                    var listShape = member.Shape.ModelListShape;
                    var substituteShapeData = member.model.Customizations.GetSubstituteShapeData(listShape.Name);
                    if (substituteShapeData != null)
                    {
                        if (substituteShapeData[CustomizationsModel.EmitFromMemberKey] != null)
                        {
                            var valueMember = (string)substituteShapeData[CustomizationsModel.EmitFromMemberKey];
                            if (isEC2Protocol)
                                testExpression += "/" + TransformUnmarshallLocationName(true, valueMember);
                            else
                                testExpression += "/" + valueMember;
                        }
                        else
                        {
                            if (listShape.ValueMarshallName != null)
                                testExpression += "/" + listShape.ValueMarshallName;
                        }
                    }
                }
                else
                {
                    testExpression = member.Shape.ListMarshallName;
                }
            }
            else if (member.IsMap)
            {
                if (!member.Shape.IsFlattened)
                    testExpression += "/entry";
            }
            else
            {
                var substituteShapeData = member.model.Customizations.GetSubstituteShapeData(member.ModelShape.Name);
                if (substituteShapeData != null && substituteShapeData[CustomizationsModel.EmitFromMemberKey] != null)
                {
                    var valueMember = (string)substituteShapeData[CustomizationsModel.EmitFromMemberKey];
                    var subMember = member.ModelShape.Members.Single(m => m.PropertyName.Equals(valueMember, StringComparison.Ordinal));

                    var subExpression = string.IsNullOrEmpty(subMember.MarshallLocationName)
                        ? subMember.MarshallName
                        : subMember.MarshallLocationName;

                    if (!string.IsNullOrEmpty(subExpression))
                        testExpression += "/" + subExpression;
                }
            }

            return testExpression;
        }

        /// <summary>
        /// Returns true if the specified operation has been tagged as requiring the usual
        /// 'Result' class suppressed (due to a void return type)
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static bool HasSuppressedResult(Operation operation)
        {
            return operation.model.Customizations.ResultGenerationSuppressions.Contains(operation.Name);
        }

        // common code to upper case, when EC2, the first char of the marshall location name
        public static string TransformMarshallLocationName(bool isEC2Protocol, string locationName)
        {
            if (string.IsNullOrEmpty(locationName) || !isEC2Protocol)
                return locationName;

            return string.Concat(locationName.Substring(0, 1).ToUpper(), locationName.Substring(1));
        }

        // common code to lower case, when EC2, the first char of the unmarshall location name
        public static string TransformUnmarshallLocationName(bool isEC2Protocol, string locationName)
        {
            if (string.IsNullOrEmpty(locationName) || !isEC2Protocol)
                return locationName;

            return string.Concat(locationName.Substring(0, 1).ToLower(), locationName.Substring(1));
        }

        /// <summary>
        /// Sets the first character of the param to lower, if it's an acronym it lowers it all until the next word
        /// </summary>
        /// <param name="param">The name of the parameter name for the constructor</param>
        /// <returns>The parameter as a camel cased name</returns>
        public static string CamelCaseParam(string param)
        {
            if (param.Length < 2 || char.IsUpper(param.ToCharArray()[0]) && char.IsLower(param.ToCharArray()[1]))
            {
                if ((char.ToLower(param.ToCharArray()[0]) + param.Substring(1)).Equals("namespace"))
                {
                    return "awsNamespace";
                }
                return param.Length < 2 ? param.ToLower() : char.ToLower(param.ToCharArray()[0]) + param.Substring(1);
            }

            // If it gets here it's an accronym

            int secondWord = 0;
            for (int i = 0; i < param.ToCharArray().Length - 1; i++)
            {
                if (char.IsUpper(param.ToCharArray()[i]) && char.IsLower(param.ToCharArray()[i + 1]))
                {
                    secondWord = i;
                    break;
                }
                else if (char.IsUpper(param.ToCharArray()[i]) && char.IsUpper(param.ToCharArray()[i + 1]))
                {
                    continue;
                }
            }

            if (secondWord == 0)
            {
                if (param.ToLower().Equals("namespace"))
                {
                    return "awsNamespace";
                }
                return param.ToLower();
            }

            var camelParam = new StringBuilder();
            for (int i = 0; i < secondWord; i++)
            {
                camelParam.Append(char.ToLower(param.ToCharArray()[i]));
            }
            camelParam.Append(param.Substring(secondWord));

            if (camelParam.ToString().Equals("namespace"))
            {
                return "awsNamespace";
            }

            return camelParam.ToString();
        }
    }

    public static class StringExtensions
    {
        public static string ToCamelCase(this string s)
        {
            return GeneratorHelpers.CamelCaseParam(s);
        }

        public static string ToClassMemberCase(this string s)
        {
            return "_" + s.ToCamelCase();
        }
    }
}
