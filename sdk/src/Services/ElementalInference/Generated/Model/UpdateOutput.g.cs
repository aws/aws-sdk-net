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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains configuration information about one output in a feed. It is used in the UpdateFeed
    /// action.
    /// </summary>
    public partial class UpdateOutput
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FromAssociation. 
        /// <para>
        /// Elemental Inference originally sets this parameter to True if this output was created
        /// by AssociateFeed or to False if this output was created by CreateFeed or UpdateFeed.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must not change this value. Therefore, use GetFeed to determine the current value.
        /// Then in the UpdateFeed request, if the current value is True, include this parameter
        /// with a value of True. If it's False, omit the parameter. 
        /// </para>
        /// </summary>
        public bool? FromAssociation { get; set; }

        /// <summary>
        /// Checks to see if the FromAssociation property is set.
        /// </summary>
        internal bool IsSetFromAssociation() => this.FromAssociation.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// A typed property for an output in a feed. It identifies the action for Elemental Inference
        /// to perform. It also provides a repository for the results of that action. For example,
        /// CroppingConfig output will contain the metadata for the crop feature. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
