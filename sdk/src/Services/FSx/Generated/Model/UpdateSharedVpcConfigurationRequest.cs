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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSharedVpcConfiguration operation.
    /// Configures whether participant accounts in your organization can create Amazon FSx
    /// for NetApp ONTAP Multi-AZ file systems in subnets that are shared by a virtual private
    /// cloud (VPC) owner. For more information, see the <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/maz-shared-vpc.html">Amazon
    /// FSx for NetApp ONTAP User Guide</a>.
    /// 
    ///  <note> 
    /// <para>
    /// We strongly recommend that participant-created Multi-AZ file systems in the shared
    /// VPC are deleted before you disable this feature. Once the feature is disabled, these
    /// file systems will enter a <c>MISCONFIGURED</c> state and behave like Single-AZ file
    /// systems. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/maz-shared-vpc.html#disabling-maz-vpc-sharing">Important
    /// considerations before disabling shared VPC support for Multi-AZ file systems</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateSharedVpcConfigurationRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _enableFsxRouteTableUpdatesFromParticipantAccounts;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property EnableFsxRouteTableUpdatesFromParticipantAccounts. 
        /// <para>
        /// Specifies whether participant accounts can create FSx for ONTAP Multi-AZ file systems
        /// in shared subnets. Set to <c>true</c> to enable or <c>false</c> to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=5)]
        public string EnableFsxRouteTableUpdatesFromParticipantAccounts
        {
            get { return this._enableFsxRouteTableUpdatesFromParticipantAccounts; }
            set { this._enableFsxRouteTableUpdatesFromParticipantAccounts = value; }
        }

        // Check to see if EnableFsxRouteTableUpdatesFromParticipantAccounts property is set
        internal bool IsSetEnableFsxRouteTableUpdatesFromParticipantAccounts()
        {
            return this._enableFsxRouteTableUpdatesFromParticipantAccounts != null;
        }

    }
}