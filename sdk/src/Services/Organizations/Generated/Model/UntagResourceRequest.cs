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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes any tags with the specified keys from the specified resource.
    /// 
    ///  
    /// <para>
    /// You can attach tags to the following resources in Organizations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Web Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organization root
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organizational unit (OU)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Policy (any type)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class UntagResourceRequest : AmazonOrganizationsRequest
    {
        private string _resourceId;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource to remove a tag from.
        /// </para>
        ///  
        /// <para>
        /// You can specify any of the following taggable resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services account – specify the account ID number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit – specify the OU ID that begins with <c>ou-</c> and looks similar
        /// to: <c>ou-<i>1a2b-34uvwxyz</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Root – specify the root ID that begins with <c>r-</c> and looks similar to: <c>r-<i>1a2b</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy – specify the policy ID that begins with <c>p-</c> andlooks similar to: <c>p-<i>12abcdefg3</i>
        /// </c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=130)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The list of keys for tags to remove from the specified resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}