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

/*
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAllowList operation.
    /// Creates and defines the settings for an allow list.
    /// </summary>
    public partial class CreateAllowListRequest : AmazonMacie2Request
    {
        private string _clientToken;
        private AllowListCriteria _criteria;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The criteria that specify the text or text pattern to ignore. The criteria can be
        /// the location and name of an S3 object that lists specific text to ignore (s3WordsList),
        /// or a regular expression (regex) that defines a text pattern to ignore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowListCriteria Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the allow list. The description can contain as many as 512
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the allow list. The name can contain as many as 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies the tags to associate with the allow list.
        /// </para>
        ///  
        /// <para>
        /// An allow list can have a maximum of 50 tags. Each tag consists of a tag key and an
        /// associated tag value. The maximum length of a tag key is 128 characters. The maximum
        /// length of a tag value is 256 characters.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}