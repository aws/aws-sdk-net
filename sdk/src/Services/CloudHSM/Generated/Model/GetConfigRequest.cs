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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfig operation.
    /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
    /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
    /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
    /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>.
    /// 
    ///  
    /// <para>
    ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>.
    /// </para>
    ///  
    /// <para>
    /// Gets the configuration files necessary to connect to all high availability partition
    /// groups the client is associated with.
    /// </para>
    /// </summary>
    public partial class GetConfigRequest : AmazonCloudHSMRequest
    {
        private string _clientArn;
        private ClientVersion _clientVersion;
        private List<string> _hapgList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientArn. 
        /// <para>
        /// The ARN of the client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientArn
        {
            get { return this._clientArn; }
            set { this._clientArn = value; }
        }

        // Check to see if ClientArn property is set
        internal bool IsSetClientArn()
        {
            return this._clientArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVersion. 
        /// <para>
        /// The client version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientVersion ClientVersion
        {
            get { return this._clientVersion; }
            set { this._clientVersion = value; }
        }

        // Check to see if ClientVersion property is set
        internal bool IsSetClientVersion()
        {
            return this._clientVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HapgList. 
        /// <para>
        /// A list of ARNs that identify the high-availability partition groups that are associated
        /// with the client.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> HapgList
        {
            get { return this._hapgList; }
            set { this._hapgList = value; }
        }

        // Check to see if HapgList property is set
        internal bool IsSetHapgList()
        {
            return this._hapgList != null && (this._hapgList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}