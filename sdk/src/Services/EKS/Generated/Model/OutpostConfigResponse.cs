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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the configuration of your local Amazon EKS cluster on an Amazon
    /// Web Services Outpost. This API isn't available for Amazon EKS clusters on the Amazon
    /// Web Services cloud.
    /// </summary>
    public partial class OutpostConfigResponse
    {
        private string _controlPlaneInstanceType;
        private ControlPlanePlacementResponse _controlPlanePlacement;
        private List<string> _outpostArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ControlPlaneInstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used for the control plane. The instance type is the
        /// same for all control plane instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ControlPlaneInstanceType
        {
            get { return this._controlPlaneInstanceType; }
            set { this._controlPlaneInstanceType = value; }
        }

        // Check to see if ControlPlaneInstanceType property is set
        internal bool IsSetControlPlaneInstanceType()
        {
            return this._controlPlaneInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ControlPlanePlacement. 
        /// <para>
        /// An object representing the placement configuration for all the control plane instances
        /// of your local Amazon EKS cluster on an Amazon Web Services Outpost. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html">Capacity
        /// considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public ControlPlanePlacementResponse ControlPlanePlacement
        {
            get { return this._controlPlanePlacement; }
            set { this._controlPlanePlacement = value; }
        }

        // Check to see if ControlPlanePlacement property is set
        internal bool IsSetControlPlanePlacement()
        {
            return this._controlPlanePlacement != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArns. 
        /// <para>
        /// The ARN of the Outpost that you specified for use with your local Amazon EKS cluster
        /// on Outposts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OutpostArns
        {
            get { return this._outpostArns; }
            set { this._outpostArns = value; }
        }

        // Check to see if OutpostArns property is set
        internal bool IsSetOutpostArns()
        {
            return this._outpostArns != null && this._outpostArns.Count > 0; 
        }

    }
}