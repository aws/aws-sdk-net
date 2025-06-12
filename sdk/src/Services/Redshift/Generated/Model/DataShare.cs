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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// 
    /// </summary>
    public partial class DataShare
    {
        private bool? _allowPubliclyAccessibleConsumers;
        private string _dataShareArn;
        private List<DataShareAssociation> _dataShareAssociations = AWSConfigs.InitializeCollections ? new List<DataShareAssociation>() : null;
        private DataShareType _dataShareType;
        private string _managedBy;
        private string _producerArn;

        /// <summary>
        /// Gets and sets the property AllowPubliclyAccessibleConsumers. 
        /// <para>
        /// A value that specifies whether the datashare can be shared to a publicly accessible
        /// cluster.
        /// </para>
        /// </summary>
        public bool? AllowPubliclyAccessibleConsumers
        {
            get { return this._allowPubliclyAccessibleConsumers; }
            set { this._allowPubliclyAccessibleConsumers = value; }
        }

        // Check to see if AllowPubliclyAccessibleConsumers property is set
        internal bool IsSetAllowPubliclyAccessibleConsumers()
        {
            return this._allowPubliclyAccessibleConsumers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the datashare that the consumer is to use.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DataShareArn
        {
            get { return this._dataShareArn; }
            set { this._dataShareArn = value; }
        }

        // Check to see if DataShareArn property is set
        internal bool IsSetDataShareArn()
        {
            return this._dataShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataShareAssociations. 
        /// <para>
        /// A value that specifies when the datashare has an association between producer and
        /// data consumers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataShareAssociation> DataShareAssociations
        {
            get { return this._dataShareAssociations; }
            set { this._dataShareAssociations = value; }
        }

        // Check to see if DataShareAssociations property is set
        internal bool IsSetDataShareAssociations()
        {
            return this._dataShareAssociations != null && (this._dataShareAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataShareType. 
        /// <para>
        ///  The type of the datashare created by RegisterNamespace.
        /// </para>
        /// </summary>
        public DataShareType DataShareType
        {
            get { return this._dataShareType; }
            set { this._dataShareType = value; }
        }

        // Check to see if DataShareType property is set
        internal bool IsSetDataShareType()
        {
            return this._dataShareType != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The identifier of a datashare to show its managing entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ProducerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the producer namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ProducerArn
        {
            get { return this._producerArn; }
            set { this._producerArn = value; }
        }

        // Check to see if ProducerArn property is set
        internal bool IsSetProducerArn()
        {
            return this._producerArn != null;
        }

    }
}