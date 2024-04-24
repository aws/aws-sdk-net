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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// A setting that enables metrics at the object level. Each rule contains an object group
    /// and an object group name. If the policy includes the MetricPolicyRules parameter,
    /// you must include at least one rule. Each metric policy can include up to five rules
    /// by default. You can also <a href="https://console.aws.amazon.com/servicequotas/home?region=us-east-1#!/services/mediastore/quotas">request
    /// a quota increase</a> to allow up to 300 rules per policy.
    /// </summary>
    public partial class MetricPolicyRule
    {
        private string _objectGroup;
        private string _objectGroupName;

        /// <summary>
        /// Gets and sets the property ObjectGroup. 
        /// <para>
        /// A path or file name that defines which objects to include in the group. Wildcards
        /// (*) are acceptable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=900)]
        public string ObjectGroup
        {
            get { return this._objectGroup; }
            set { this._objectGroup = value; }
        }

        // Check to see if ObjectGroup property is set
        internal bool IsSetObjectGroup()
        {
            return this._objectGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectGroupName. 
        /// <para>
        /// A name that allows you to refer to the object group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string ObjectGroupName
        {
            get { return this._objectGroupName; }
            set { this._objectGroupName = value; }
        }

        // Check to see if ObjectGroupName property is set
        internal bool IsSetObjectGroupName()
        {
            return this._objectGroupName != null;
        }

    }
}