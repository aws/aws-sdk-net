/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes the parameters for Select job types.
    /// </summary>
    public partial class SelectParameters
    {   
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            if (!IsSetInputSerialization()) throw new System.ArgumentException("SelectParameters.InputSerialization is a required property and must be set before making this call.");
            if (!IsSetExpression())         throw new System.ArgumentException("SelectParameters.Expression is a required property and must be set before making this call.");
            if (!IsSetExpressionType())     throw new System.ArgumentException("SelectParameters.ExpressionType is a required property and must be set before making this call.");
            if (!IsSetOutputSerialization())throw new System.ArgumentException("SelectParameters.OutputSerialization is a required property and must be set before making this call.");

            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetInputSerialization())
                    InputSerialization.Marshall("InputSerialization", xmlWriter);
                if (IsSetExpressionType())
                    xmlWriter.WriteElementString("ExpressionType", S3Transforms.ToXmlStringValue(ExpressionType.Value));
                if (IsSetExpression())
                    xmlWriter.WriteElementString("Expression", S3Transforms.ToXmlStringValue(Expression));
                if (IsSetOutputSerialization())
                    OutputSerialization.Marshall("OutputSerialization", xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
    }
}