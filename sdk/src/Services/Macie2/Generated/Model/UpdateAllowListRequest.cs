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
    /// Container for the parameters to the UpdateAllowList operation.
    /// Updates the settings for an allow list.
    /// </summary>
    public partial class UpdateAllowListRequest : AmazonMacie2Request
    {
        private AllowListCriteria _criteria;
        private string _description;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The criteria that specify the text or text pattern to ignore. The criteria can be
        /// the location and name of an S3 object that lists specific text to ignore (s3WordsList),
        /// or a regular expression that defines a text pattern to ignore (regex).
        /// </para>
        ///  
        /// <para>
        /// You can change a list's underlying criteria, such as the name of the S3 object or
        /// the regular expression to use. However, you can't change the type from s3WordsList
        /// to regex or the other way around.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the Amazon Macie resource that the request applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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

    }
}