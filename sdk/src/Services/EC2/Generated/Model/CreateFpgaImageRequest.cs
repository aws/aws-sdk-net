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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFpgaImage operation.
    /// Creates an Amazon FPGA Image (AFI) from the specified design checkpoint (DCP).
    /// 
    ///  
    /// <para>
    /// The create operation is asynchronous. To verify that the AFI is ready for use, check
    /// the output logs.
    /// </para>
    ///  
    /// <para>
    /// An AFI contains the FPGA bitstream that is ready to download to an FPGA. You can securely
    /// deploy an AFI on multiple FPGA-accelerated instances. For more information, see the
    /// <a href="https://github.com/aws/aws-fpga/">AWS FPGA Hardware Development Kit</a>.
    /// </para>
    /// </summary>
    public partial class CreateFpgaImageRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private StorageLocation _inputStorageLocation;
        private StorageLocation _logsStorageLocation;
        private string _name;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the AFI.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputStorageLocation. 
        /// <para>
        /// The location of the encrypted design checkpoint in Amazon S3. The input must be a
        /// tarball.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLocation InputStorageLocation
        {
            get { return this._inputStorageLocation; }
            set { this._inputStorageLocation = value; }
        }

        // Check to see if InputStorageLocation property is set
        internal bool IsSetInputStorageLocation()
        {
            return this._inputStorageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property LogsStorageLocation. 
        /// <para>
        /// The location in Amazon S3 for the output logs.
        /// </para>
        /// </summary>
        public StorageLocation LogsStorageLocation
        {
            get { return this._logsStorageLocation; }
            set { this._logsStorageLocation = value; }
        }

        // Check to see if LogsStorageLocation property is set
        internal bool IsSetLogsStorageLocation()
        {
            return this._logsStorageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the AFI.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the FPGA image during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}