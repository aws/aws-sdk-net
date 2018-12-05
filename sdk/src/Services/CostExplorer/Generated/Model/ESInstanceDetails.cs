/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the Amazon ES instances that AWS recommends that you purchase.
    /// </summary>
    public partial class ESInstanceDetails
    {
        private bool? _currentGeneration;
        private string _instanceClass;
        private string _instanceSize;
        private string _region;
        private bool? _sizeFlexEligible;

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Whether the recommendation is for a current-generation instance.
        /// </para>
        /// </summary>
        public bool CurrentGeneration
        {
            get { return this._currentGeneration.GetValueOrDefault(); }
            set { this._currentGeneration = value; }
        }

        // Check to see if CurrentGeneration property is set
        internal bool IsSetCurrentGeneration()
        {
            return this._currentGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceClass. 
        /// <para>
        /// The class of instance that AWS recommends.
        /// </para>
        /// </summary>
        public string InstanceClass
        {
            get { return this._instanceClass; }
            set { this._instanceClass = value; }
        }

        // Check to see if InstanceClass property is set
        internal bool IsSetInstanceClass()
        {
            return this._instanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceSize. 
        /// <para>
        /// The size of instance that AWS recommends.
        /// </para>
        /// </summary>
        public string InstanceSize
        {
            get { return this._instanceSize; }
            set { this._instanceSize = value; }
        }

        // Check to see if InstanceSize property is set
        internal bool IsSetInstanceSize()
        {
            return this._instanceSize != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region of the recommended reservation.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Whether the recommended reservation is size flexible.
        /// </para>
        /// </summary>
        public bool SizeFlexEligible
        {
            get { return this._sizeFlexEligible.GetValueOrDefault(); }
            set { this._sizeFlexEligible = value; }
        }

        // Check to see if SizeFlexEligible property is set
        internal bool IsSetSizeFlexEligible()
        {
            return this._sizeFlexEligible.HasValue; 
        }

    }
}