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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ActivateGateway operation. Activates the gateway
    /// you previously deployed on your host. In the activation process, you specify information
    /// such as the Amazon Web Services Region that you want to use for storing snapshots
    /// or tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
    /// an activation key, and a name for your gateway. The activation process also associates
    /// your gateway with your account. For more information, see <a>UpdateGatewayInformation</a>.
    /// <note> <para> You must turn on the gateway VM before you can activate your gateway.
    /// </para> </note>
    /// </summary>
    public partial class ActivateGatewayRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Your gateway activation key. You can obtain the activation key by sending an HTTP
        /// GET request with redirects enabled to the gateway IP address (port 80). The redirect
        /// URL returned in the response provides you the activation key for your gateway in the
        /// query string parameter <c>activationKey</c>. It may also include other activation-related
        /// parameters, however, these are merely defaults -- the arguments you pass to the <c>ActivateGateway</c>
        /// API call determine the actual configuration of your gateway.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html">Getting
        /// activation key</a> in the <i>Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string ActivationKey { get; set; }

        /// <summary>
        /// Checks to see if the ActivationKey property is set.
        /// </summary>
        internal bool IsSetActivationKey() => this.ActivationKey != null;

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name you configured for your gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 255)]
        public string GatewayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayName property is set.
        /// </summary>
        internal bool IsSetGatewayName() => this.GatewayName != null;

        /// <summary>
        /// Gets and sets the property GatewayRegion. 
        /// <para>
        /// A value that indicates the Amazon Web Services Region where you want to store your
        /// data. The gateway Amazon Web Services Region specified must be the same Amazon Web
        /// Services Region as the Amazon Web Services Region in your <c>Host</c> header in the
        /// request. For more information about available Amazon Web Services Regions and endpoints
        /// for Storage Gateway, see <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">
        /// Storage Gateway endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: See <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">
        /// Storage Gateway endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public string GatewayRegion { get; set; }

        /// <summary>
        /// Checks to see if the GatewayRegion property is set.
        /// </summary>
        internal bool IsSetGatewayRegion() => this.GatewayRegion != null;

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// A value that indicates the time zone you want to set for the gateway. The time zone
        /// is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, GMT indicates Greenwich
        /// Mean Time without any offset. GMT-4:00 indicates the time is 4 hours behind GMT. GMT+2:00
        /// indicates the time is 2 hours ahead of GMT. The time zone is used, for example, for
        /// scheduling snapshots and your gateway's maintenance schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 10)]
        public string GatewayTimezone { get; set; }

        /// <summary>
        /// Checks to see if the GatewayTimezone property is set.
        /// </summary>
        internal bool IsSetGatewayTimezone() => this.GatewayTimezone != null;

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// A value that defines the type of gateway to activate. The type specified is critical
        /// to all later functions of the gateway and cannot be changed after activation. The
        /// default value is <c>CACHED</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon FSx File Gateway is no longer available to new customers. Existing customers
        /// of FSx File Gateway can continue to use the service normally. For capabilities similar
        /// to FSx File Gateway, visit <a href="https://aws.amazon.com/blogs/storage/switch-your-file-share-access-from-amazon-fsx-file-gateway-to-amazon-fsx-for-windows-file-server/">this
        /// blog post</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Valid Values: <c>STORED</c> | <c>CACHED</c> | <c>VTL</c> | <c>FILE_S3</c> | <c>FILE_FSX_SMB</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 20)]
        public string GatewayType { get; set; }

        /// <summary>
        /// Checks to see if the GatewayType property is set.
        /// </summary>
        internal bool IsSetGatewayType() => this.GatewayType != null;

        /// <summary>
        /// Gets and sets the property MediumChangerType. 
        /// <para>
        /// The value that indicates the type of medium changer to use for tape gateway. This
        /// field is optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>STK-L700</c> | <c>AWS-Gateway-VTL</c> | <c>IBM-03584L32-0402</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string MediumChangerType { get; set; }

        /// <summary>
        /// Checks to see if the MediumChangerType property is set.
        /// </summary>
        internal bool IsSetMediumChangerType() => this.MediumChangerType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that you can assign to the gateway. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers that can be represented
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256 characters.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TapeDriveType. 
        /// <para>
        /// The value that indicates the type of tape drive to use for tape gateway. This field
        /// is optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IBM-ULT3580-TD5</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string TapeDriveType { get; set; }

        /// <summary>
        /// Checks to see if the TapeDriveType property is set.
        /// </summary>
        internal bool IsSetTapeDriveType() => this.TapeDriveType != null;
    }
}
