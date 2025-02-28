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
    /// An object representing a node group launch template specification. The launch template
    /// can't include <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html">
    /// <c>SubnetId</c> </a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_IamInstanceProfile.html">
    /// <c>IamInstanceProfile</c> </a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">
    /// <c>RequestSpotInstances</c> </a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_HibernationOptionsRequest.html">
    /// <c>HibernationOptions</c> </a>, or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_TerminateInstances.html">
    /// <c>TerminateInstances</c> </a>, or the node group deployment or update will fail.
    /// For more information about launch templates, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateLaunchTemplate.html">
    /// <c>CreateLaunchTemplate</c> </a> in the Amazon EC2 API Reference. For more information
    /// about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
    /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You must specify either the launch template ID or the launch template name in the
    /// request, but not both.
    /// </para>
    /// </summary>
    public partial class LaunchTemplateSpecification
    {
        private string _id;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the launch template ID or the launch template name in the
        /// request, but not both. After node group creation, you cannot use a different ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the launch template.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the launch template name or the launch template ID in the
        /// request, but not both. After node group creation, you cannot use a different name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the launch template to use. If no version is specified, then
        /// the template's default version is used. You can use a different version for node group
        /// updates.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}