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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Describes a treatment in an experiment, including its traffic allocation weight and
    /// feature flag value.
    /// </summary>
    public partial class Treatment
    {
        private string _description;
        private FlagValue _flagValue;
        private string _key;
        private float? _weight;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property FlagValue. 
        /// <para>
        /// The feature flag value served to users assigned to this treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlagValue FlagValue
        {
            get { return this._flagValue; }
            set { this._flagValue = value; }
        }

        // Check to see if FlagValue property is set
        internal bool IsSetFlagValue()
        {
            return this._flagValue != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The unique key that identifies this treatment.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The traffic allocation weight for this treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public float? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}