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
    /// Container for the parameters to the BatchGetApplications operation.
    /// Gets information about one or more applications. The maximum number of applications
    /// that can be returned is 100.
    /// </summary>
    public partial class BatchGetApplicationsRequest : AmazonCodeDeployRequest
    {
        private List<string> _applicationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationNames. 
        /// <para>
        /// A list of application names separated by spaces. The maximum number of application
        /// names you can specify is 100.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ApplicationNames
        {
            get { return this._applicationNames; }
            set { this._applicationNames = value; }
        }

        // Check to see if ApplicationNames property is set
        internal bool IsSetApplicationNames()
        {
            return this._applicationNames != null && (this._applicationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}