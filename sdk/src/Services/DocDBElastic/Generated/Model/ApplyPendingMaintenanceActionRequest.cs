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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Container for the parameters to the ApplyPendingMaintenanceAction operation.
    /// The type of pending maintenance action to be applied to the resource.
    /// </summary>
    public partial class ApplyPendingMaintenanceActionRequest : AmazonDocDBElasticRequest
    {
        private string _applyAction;
        private string _applyOn;
        private OptInType _optInType;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ApplyAction. 
        /// <para>
        /// The pending maintenance action to apply to the resource.
        /// </para>
        ///  
        /// <para>
        /// Valid actions are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENGINE_UPDATE<i/> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENGINE_UPGRADE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECURITY_UPDATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OS_UPDATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MASTER_USER_PASSWORD_UPDATE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ApplyAction
        {
            get { return this._applyAction; }
            set { this._applyAction = value; }
        }

        // Check to see if ApplyAction property is set
        internal bool IsSetApplyAction()
        {
            return this._applyAction != null;
        }

        /// <summary>
        /// Gets and sets the property ApplyOn. 
        /// <para>
        /// A specific date to apply the pending maintenance action. Required if opt-in-type is
        /// <c>APPLY_ON</c>. Format: <c>yyyy/MM/dd HH:mm-yyyy/MM/dd HH:mm</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ApplyOn
        {
            get { return this._applyOn; }
            set { this._applyOn = value; }
        }

        // Check to see if ApplyOn property is set
        internal bool IsSetApplyOn()
        {
            return this._applyOn != null;
        }

        /// <summary>
        /// Gets and sets the property OptInType. 
        /// <para>
        /// A value that specifies the type of opt-in request, or undoes an opt-in request. An
        /// opt-in request of type <c>IMMEDIATE</c> can't be undone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptInType OptInType
        {
            get { return this._optInType; }
            set { this._optInType = value; }
        }

        // Check to see if OptInType property is set
        internal bool IsSetOptInType()
        {
            return this._optInType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon DocumentDB Amazon Resource Name (ARN) of the resource to which the pending
        /// maintenance action applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}