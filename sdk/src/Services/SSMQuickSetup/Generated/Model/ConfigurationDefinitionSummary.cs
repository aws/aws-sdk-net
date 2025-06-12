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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
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
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// A summarized definition of a Quick Setup configuration definition.
    /// </summary>
    public partial class ConfigurationDefinitionSummary
    {
        private Dictionary<string, string> _firstClassParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _id;
        private string _type;
        private string _typeVersion;

        /// <summary>
        /// Gets and sets the property FirstClassParameters. 
        /// <para>
        /// The common parameters and values for the configuration definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FirstClassParameters
        {
            get { return this._firstClassParameters; }
            set { this._firstClassParameters = value; }
        }

        // Check to see if FirstClassParameters property is set
        internal bool IsSetFirstClassParameters()
        {
            return this._firstClassParameters != null && (this._firstClassParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration definition.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Quick Setup configuration used by the configuration definition.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersion. 
        /// <para>
        /// The version of the Quick Setup type used by the configuration definition.
        /// </para>
        /// </summary>
        public string TypeVersion
        {
            get { return this._typeVersion; }
            set { this._typeVersion = value; }
        }

        // Check to see if TypeVersion property is set
        internal bool IsSetTypeVersion()
        {
            return this._typeVersion != null;
        }

    }
}