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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpsItem operation.
    /// Get information about an OpsItem by using the ID. You must have permission in Identity
    /// and Access Management (IAM) to view information about an OpsItem. For more information,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
    /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
    /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
    /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
    /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetOpsItemRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _opsItemArn;
        private string _opsItemId;

        /// <summary>
        /// Gets and sets the property OpsItemArn. 
        /// <para>
        /// The OpsItem Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string OpsItemArn
        {
            get { return this._opsItemArn; }
            set { this._opsItemArn = value; }
        }

        // Check to see if OpsItemArn property is set
        internal bool IsSetOpsItemArn()
        {
            return this._opsItemArn != null;
        }

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem that you want to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpsItemId
        {
            get { return this._opsItemId; }
            set { this._opsItemId = value; }
        }

        // Check to see if OpsItemId property is set
        internal bool IsSetOpsItemId()
        {
            return this._opsItemId != null;
        }

    }
}