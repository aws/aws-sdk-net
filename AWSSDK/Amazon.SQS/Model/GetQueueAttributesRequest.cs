/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using Attribute = Amazon.SQS.Model.Attribute;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Gets one or all attributes of a queue.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class GetQueueAttributesRequest : SQSRequest
    {    
        private string queueUrlField;
        private List<string> attributeNameField;

        /// <summary>
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the URL associated with the Amazon SQS queue.
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetQueueAttributesRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// The attribute you want to get.
        /// </summary>
        /// <remarks>
        /// Values can be: All | ApproximateNumberOfMessages | ApproximateNumberOfMessagesNotVisible | VisibilityTimeout | CreatedTimestamp | LastModifiedTimestamp | Policy
        /// </remarks>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public List<string> AttributeName
        {
            get
            {
                if (this.attributeNameField == null)
                {
                    this.attributeNameField = new List<string>();
                }
                return this.attributeNameField;
            }
            set { this.attributeNameField = value; }
        }

        /// <summary>
        /// Sets the attribute you want to get.
        /// </summary>
        /// <remarks>
        /// Values can be: All | ApproximateNumberOfMessages | ApproximateNumberOfMessagesNotVisible | VisibilityTimeout | CreatedTimestamp | LastModifiedTimestamp | Policy
        /// </remarks>
        /// <param name="list">The attribute you want to get.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetQueueAttributesRequest WithAttributeName(params string[] list)
        {
            foreach (string item in list)
            {
                AttributeName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AttributeName property is set
        /// </summary>
        /// <returns>true if AttributeName property is set</returns>
        public bool IsSetAttributeName()
        {
            return (AttributeName.Count > 0);
        }

    }
}
