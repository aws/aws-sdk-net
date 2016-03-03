/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventTopics operation.
    /// Obtains information about which SNS topics receive status messages from the specified
    /// directory.
    /// 
    ///  
    /// <para>
    /// If no input parameters are provided, such as DirectoryId or TopicName, this request
    /// describes all of the associations in the account.
    /// </para>
    /// </summary>
    public partial class DescribeEventTopicsRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private List<string> _topicNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID for which to get the list of associated SNS topics. If this member
        /// is null, associations for all Directory IDs are returned.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property TopicNames. 
        /// <para>
        /// A list of SNS topic names for which to obtain the information. If this member is null,
        /// all associations for the specified Directory ID are returned.
        /// </para>
        ///  
        /// <para>
        /// An empty list results in an <code>InvalidParameterException</code> being thrown.
        /// </para>
        /// </summary>
        public List<string> TopicNames
        {
            get { return this._topicNames; }
            set { this._topicNames = value; }
        }

        // Check to see if TopicNames property is set
        internal bool IsSetTopicNames()
        {
            return this._topicNames != null && this._topicNames.Count > 0; 
        }

    }
}