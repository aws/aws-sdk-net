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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Usage associated with an entitlement resource.
    /// </summary>
    public partial class EntitlementUsage
    {
        private string _consumedValue;
        private string _maxCount;
        private string _name;
        private EntitlementDataUnit _unit;

        /// <summary>
        /// Gets and sets the property ConsumedValue. 
        /// <para>
        /// Resource usage consumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumedValue
        {
            get { return this._consumedValue; }
            set { this._consumedValue = value; }
        }

        // Check to see if ConsumedValue property is set
        internal bool IsSetConsumedValue()
        {
            return this._consumedValue != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// Maximum entitlement usage count.
        /// </para>
        /// </summary>
        public string MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Entitlement usage name.
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// Entitlement usage unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntitlementDataUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}