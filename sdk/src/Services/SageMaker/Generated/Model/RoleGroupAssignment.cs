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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the mapping between an in-app role and the AWS IAM Identity Center group patterns
    /// that should be assigned to that role within the SageMaker Partner AI App.
    /// </summary>
    public partial class RoleGroupAssignment
    {
        private List<string> _groupPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property GroupPatterns. 
        /// <para>
        /// A list of AWS IAM Identity Center group patterns that should be assigned to the specified
        /// role. Group patterns support wildcard matching using <c>*</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> GroupPatterns
        {
            get { return this._groupPatterns; }
            set { this._groupPatterns = value; }
        }

        // Check to see if GroupPatterns property is set
        internal bool IsSetGroupPatterns()
        {
            return this._groupPatterns != null && (this._groupPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the in-app role within the SageMaker Partner AI App. The specific roles
        /// available depend on the app type and version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}