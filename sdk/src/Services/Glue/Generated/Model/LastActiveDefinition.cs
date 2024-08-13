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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// When there are multiple versions of a blueprint and the latest version has some errors,
    /// this attribute indicates the last successful blueprint definition that is available
    /// with the service.
    /// </summary>
    public partial class LastActiveDefinition
    {
        private string _blueprintLocation;
        private string _blueprintServiceLocation;
        private string _description;
        private DateTime? _lastModifiedOn;
        private string _parameterSpec;

        /// <summary>
        /// Gets and sets the property BlueprintLocation. 
        /// <para>
        /// Specifies a path in Amazon S3 where the blueprint is published by the Glue developer.
        /// </para>
        /// </summary>
        public string BlueprintLocation
        {
            get { return this._blueprintLocation; }
            set { this._blueprintLocation = value; }
        }

        // Check to see if BlueprintLocation property is set
        internal bool IsSetBlueprintLocation()
        {
            return this._blueprintLocation != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintServiceLocation. 
        /// <para>
        /// Specifies a path in Amazon S3 where the blueprint is copied when you create or update
        /// the blueprint.
        /// </para>
        /// </summary>
        public string BlueprintServiceLocation
        {
            get { return this._blueprintServiceLocation; }
            set { this._blueprintServiceLocation = value; }
        }

        // Check to see if BlueprintServiceLocation property is set
        internal bool IsSetBlueprintServiceLocation()
        {
            return this._blueprintServiceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time the blueprint was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn
        {
            get { return this._lastModifiedOn; }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterSpec. 
        /// <para>
        /// A JSON string specifying the parameters for the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string ParameterSpec
        {
            get { return this._parameterSpec; }
            set { this._parameterSpec = value; }
        }

        // Check to see if ParameterSpec property is set
        internal bool IsSetParameterSpec()
        {
            return this._parameterSpec != null;
        }

    }
}