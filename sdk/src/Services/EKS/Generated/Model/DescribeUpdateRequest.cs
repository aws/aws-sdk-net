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
    /// Container for the parameters to the DescribeUpdate operation.
    /// Describes an update to an Amazon EKS resource.
    /// 
    ///  
    /// <para>
    /// When the status of the update is <c>Successful</c>, the update is complete. If an
    /// update fails, the status is <c>Failed</c>, and an error detail explains the reason
    /// for the failure.
    /// </para>
    /// </summary>
    public partial class DescribeUpdateRequest : AmazonEKSRequest
    {
        private string _addonName;
        private string _name;
        private string _nodegroupName;
        private string _updateId;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListAddons.html">
        /// <c>ListAddons</c> </a>. This parameter is required if the update is an add-on update.
        /// </para>
        /// </summary>
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster associated with the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name of the Amazon EKS node group associated with the update. This parameter is
        /// required if the update is a node group update.
        /// </para>
        /// </summary>
        public string NodegroupName
        {
            get { return this._nodegroupName; }
            set { this._nodegroupName = value; }
        }

        // Check to see if NodegroupName property is set
        internal bool IsSetNodegroupName()
        {
            return this._nodegroupName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateId. 
        /// <para>
        /// The ID of the update to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UpdateId
        {
            get { return this._updateId; }
            set { this._updateId = value; }
        }

        // Check to see if UpdateId property is set
        internal bool IsSetUpdateId()
        {
            return this._updateId != null;
        }

    }
}