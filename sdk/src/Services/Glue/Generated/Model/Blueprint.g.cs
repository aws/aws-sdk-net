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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The details of a blueprint.
    /// </summary>
    public partial class Blueprint
    {
        /// <summary>
        /// Gets and sets the property BlueprintLocation. 
        /// <para>
        /// Specifies the path in Amazon S3 where the blueprint is published.
        /// </para>
        /// </summary>
        public string BlueprintLocation { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintLocation property is set.
        /// </summary>
        internal bool IsSetBlueprintLocation() => this.BlueprintLocation != null;

        /// <summary>
        /// Gets and sets the property BlueprintServiceLocation. 
        /// <para>
        /// Specifies a path in Amazon S3 where the blueprint is copied when you call <c>CreateBlueprint/UpdateBlueprint</c>
        /// to register the blueprint in Glue.
        /// </para>
        /// </summary>
        public string BlueprintServiceLocation { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintServiceLocation property is set.
        /// </summary>
        internal bool IsSetBlueprintServiceLocation() => this.BlueprintServiceLocation != null;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date and time the blueprint was registered.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastActiveDefinition. 
        /// <para>
        /// When there are multiple versions of a blueprint and the latest version has some errors,
        /// this attribute indicates the last successful blueprint definition that is available
        /// with the service.
        /// </para>
        /// </summary>
        public LastActiveDefinition LastActiveDefinition { get; set; }

        /// <summary>
        /// Checks to see if the LastActiveDefinition property is set.
        /// </summary>
        internal bool IsSetLastActiveDefinition() => this.LastActiveDefinition != null;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time the blueprint was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterSpec. 
        /// <para>
        /// A JSON string that indicates the list of parameter specifications for the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string ParameterSpec { get; set; }

        /// <summary>
        /// Checks to see if the ParameterSpec property is set.
        /// </summary>
        internal bool IsSetParameterSpec() => this.ParameterSpec != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the blueprint registration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating — The blueprint registration is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Active — The blueprint has been successfully registered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updating — An update to the blueprint registration is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed — The blueprint registration failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlueprintStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
