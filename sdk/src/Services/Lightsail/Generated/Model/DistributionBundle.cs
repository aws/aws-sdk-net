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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the specifications of a distribution bundle.
    /// </summary>
    public partial class DistributionBundle
    {
        private string _bundleId;
        private bool? _isActive;
        private string _name;
        private float? _price;
        private int? _transferPerMonthInGb;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Indicates whether the bundle is active, and can be specified for a new distribution.
        /// </para>
        /// </summary>
        public bool IsActive
        {
            get { return this._isActive.GetValueOrDefault(); }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution bundle.
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
        /// Gets and sets the property Price. 
        /// <para>
        /// The monthly price, in US dollars, of the bundle.
        /// </para>
        /// </summary>
        public float Price
        {
            get { return this._price.GetValueOrDefault(); }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The monthly network transfer quota of the bundle.
        /// </para>
        /// </summary>
        public int TransferPerMonthInGb
        {
            get { return this._transferPerMonthInGb.GetValueOrDefault(); }
            set { this._transferPerMonthInGb = value; }
        }

        // Check to see if TransferPerMonthInGb property is set
        internal bool IsSetTransferPerMonthInGb()
        {
            return this._transferPerMonthInGb.HasValue; 
        }

    }
}