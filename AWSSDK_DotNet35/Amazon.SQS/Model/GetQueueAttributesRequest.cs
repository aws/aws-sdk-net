/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetQueueAttributesRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = new List<string>();
        private string _queueUrl;


        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attributes to retrieve information for. 
        /// </para>
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
        /// </para>
        /// </summary>
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

    }
}