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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// This value indicates if extended support is enabled or disabled for the cluster.
    /// 
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/extended-support-control.html">Learn
    /// more about EKS Extended Support in the <i>Amazon EKS User Guide</i>.</a> 
    /// </para>
    /// </summary>
    public partial class UpgradePolicyResponse
    {
        private SupportType _supportType;

        /// <summary>
        /// Gets and sets the property SupportType. 
        /// <para>
        /// If the cluster is set to <c>EXTENDED</c>, it will enter extended support at the end
        /// of standard support. If the cluster is set to <c>STANDARD</c>, it will be automatically
        /// upgraded at the end of standard support.
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/extended-support-control.html">Learn
        /// more about EKS Extended Support in the <i>Amazon EKS User Guide</i>.</a> 
        /// </para>
        /// </summary>
        public SupportType SupportType
        {
            get { return this._supportType; }
            set { this._supportType = value; }
        }

        // Check to see if SupportType property is set
        internal bool IsSetSupportType()
        {
            return this._supportType != null;
        }

    }
}