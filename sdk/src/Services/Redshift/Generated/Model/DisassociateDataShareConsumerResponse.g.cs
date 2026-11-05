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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DisassociateDataShareConsumer operation.
    /// </summary>
    public partial class DisassociateDataShareConsumerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowPubliclyAccessibleConsumers. 
        /// <para>
        /// A value that specifies whether the datashare can be shared to a publicly accessible
        /// cluster.
        /// </para>
        /// </summary>
        public bool? AllowPubliclyAccessibleConsumers { get; set; }

        /// <summary>
        /// Checks to see if the AllowPubliclyAccessibleConsumers property is set.
        /// </summary>
        internal bool IsSetAllowPubliclyAccessibleConsumers() => this.AllowPubliclyAccessibleConsumers.HasValue;

        /// <summary>
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the datashare that the consumer is to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DataShareArn { get; set; }

        /// <summary>
        /// Checks to see if the DataShareArn property is set.
        /// </summary>
        internal bool IsSetDataShareArn() => this.DataShareArn != null;

        /// <summary>
        /// Gets and sets the property DataShareAssociations. 
        /// <para>
        /// A value that specifies when the datashare has an association between producer and
        /// data consumers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataShareAssociation> DataShareAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<DataShareAssociation>() : null;

        /// <summary>
        /// Checks to see if the DataShareAssociations property is set.
        /// </summary>
        internal bool IsSetDataShareAssociations() => this.DataShareAssociations != null && (this.DataShareAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataShareType. 
        /// <para>
        ///  The type of the datashare created by RegisterNamespace.
        /// </para>
        /// </summary>
        public DataShareType DataShareType { get; set; }

        /// <summary>
        /// Checks to see if the DataShareType property is set.
        /// </summary>
        internal bool IsSetDataShareType() => this.DataShareType != null;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The identifier of a datashare to show its managing entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property ProducerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the producer namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ProducerArn { get; set; }

        /// <summary>
        /// Checks to see if the ProducerArn property is set.
        /// </summary>
        internal bool IsSetProducerArn() => this.ProducerArn != null;
    }
}
