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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeThing operation.
    /// </summary>
    public partial class DescribeThingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The thing attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name of the billing group the thing belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BillingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupName property is set.
        /// </summary>
        internal bool IsSetBillingGroupName() => this.BillingGroupName != null;

        /// <summary>
        /// Gets and sets the property DefaultClientId. 
        /// <para>
        /// The default MQTT client ID. For a typical device, the thing name is also used as the
        /// default MQTT client ID. Although we don’t require a mapping between a thing's registry
        /// name and its use of MQTT client IDs, certificates, or shadow state, we recommend that
        /// you choose a thing name and use it as the MQTT client ID for the registry and the
        /// Device Shadow service.
        /// </para>
        ///  
        /// <para>
        /// This lets you better organize your IoT fleet without removing the flexibility of the
        /// underlying device certificate model or shadows.
        /// </para>
        /// </summary>
        public string DefaultClientId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultClientId property is set.
        /// </summary>
        internal bool IsSetDefaultClientId() => this.DefaultClientId != null;

        /// <summary>
        /// Gets and sets the property ThingArn. 
        /// <para>
        /// The ARN of the thing to describe.
        /// </para>
        /// </summary>
        public string ThingArn { get; set; }

        /// <summary>
        /// Checks to see if the ThingArn property is set.
        /// </summary>
        internal bool IsSetThingArn() => this.ThingArn != null;

        /// <summary>
        /// Gets and sets the property ThingId. 
        /// <para>
        /// The ID of the thing to describe.
        /// </para>
        /// </summary>
        public string ThingId { get; set; }

        /// <summary>
        /// Checks to see if the ThingId property is set.
        /// </summary>
        internal bool IsSetThingId() => this.ThingId != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The thing type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeName property is set.
        /// </summary>
        internal bool IsSetThingTypeName() => this.ThingTypeName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the thing record in the registry.
        /// </para>
        ///  <note> 
        /// <para>
        /// To avoid unintentional changes to the information in the registry, you can pass the
        /// version information in the <c>expectedVersion</c> parameter of the <c>UpdateThing</c>
        /// and <c>DeleteThing</c> calls.
        /// </para>
        ///  </note>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
