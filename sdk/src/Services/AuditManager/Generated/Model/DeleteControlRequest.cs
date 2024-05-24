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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteControl operation.
    /// Deletes a custom control in Audit Manager. 
    /// 
    ///  <important> 
    /// <para>
    /// When you invoke this operation, the custom control is deleted from any frameworks
    /// or assessments that it’s currently part of. As a result, Audit Manager will stop collecting
    /// evidence for that custom control in all of your assessments. This includes assessments
    /// that you previously created before you deleted the custom control.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteControlRequest : AmazonAuditManagerRequest
    {
        private string _controlId;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The unique identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

    }
}