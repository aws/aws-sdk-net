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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about groups of Amazon EC2 instance tags.
    /// </summary>
    public partial class EC2TagSet
    {
        private List<List<EC2TagFilter>> _ec2TagSetList = AWSConfigs.InitializeCollections ? new List<List<EC2TagFilter>>() : null;

        /// <summary>
        /// Gets and sets the property Ec2TagSetList. 
        /// <para>
        /// A list that contains other lists of Amazon EC2 instance tag groups. For an instance
        /// to be included in the deployment group, it must be identified by all of the tag groups
        /// in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<EC2TagFilter>> Ec2TagSetList
        {
            get { return this._ec2TagSetList; }
            set { this._ec2TagSetList = value; }
        }

        // Check to see if Ec2TagSetList property is set
        internal bool IsSetEc2TagSetList()
        {
            return this._ec2TagSetList != null && (this._ec2TagSetList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}