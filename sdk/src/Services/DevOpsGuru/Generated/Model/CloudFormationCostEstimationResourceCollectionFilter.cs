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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about an Amazon Web Services CloudFormation stack used to create a monthly
    /// cost estimate for DevOps Guru to analyze Amazon Web Services resources. The maximum
    /// number of stacks you can specify for a cost estimate is one. The estimate created
    /// is for the cost to analyze the Amazon Web Services resources defined by the stack.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Stacks</a>
    /// in the <i>Amazon Web Services CloudFormation User Guide</i>.
    /// </summary>
    public partial class CloudFormationCostEstimationResourceCollectionFilter
    {
        private List<string> _stackNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property StackNames. 
        /// <para>
        /// An array of CloudFormation stack names. Its size is fixed at 1 item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> StackNames
        {
            get { return this._stackNames; }
            set { this._stackNames = value; }
        }

        // Check to see if StackNames property is set
        internal bool IsSetStackNames()
        {
            return this._stackNames != null && (this._stackNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}