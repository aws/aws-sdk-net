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
    /// Container for the parameters to the DescribeLineageGroup operation.
    /// Provides a list of properties for the requested lineage group. For more information,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
    /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class DescribeLineageGroupRequest : AmazonSageMakerRequest
    {
        private string _lineageGroupName;

        /// <summary>
        /// Gets and sets the property LineageGroupName. 
        /// <para>
        /// The name of the lineage group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string LineageGroupName
        {
            get { return this._lineageGroupName; }
            set { this._lineageGroupName = value; }
        }

        // Check to see if LineageGroupName property is set
        internal bool IsSetLineageGroupName()
        {
            return this._lineageGroupName != null;
        }

    }
}