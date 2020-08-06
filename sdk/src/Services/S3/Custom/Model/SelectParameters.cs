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
    public class SelectParameters
    {
        /// <summary>
        /// Describes the serialization format of the object.
        /// </summary>
        public InputSerialization InputSerialization { get; set; }

        internal bool IsSetInputSerialization()
        {
            return this.InputSerialization != null;
        }

        /// <summary>
        /// The type of the provided expression (e.g., SQL).
        /// </summary>
        public ExpressionType ExpressionType { get; set; }

        internal bool IsSetExpressionType()
        {
            return this.ExpressionType != null;
        }

        /// <summary>
        /// The expression that is used to query the object.
        /// </summary>
        public string Expression { get; set; } 

        internal bool IsSetExpression()
        {
            return this.Expression != null;
        }

        /// <summary>
        /// Describes how the results of the Select job are serialized.
        /// </summary>
        public OutputSerialization OutputSerialization { get; set; }

        internal bool IsSetOutputSerialization()
        {
            return this.OutputSerialization != null;
        }
        
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