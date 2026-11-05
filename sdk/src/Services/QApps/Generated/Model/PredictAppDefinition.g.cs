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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// The definition of an Amazon Q App generated based on input such as a conversation
    /// or problem statement.
    /// </summary>
    public partial class PredictAppDefinition
    {
        /// <summary>
        /// Gets and sets the property AppDefinition. 
        /// <para>
        /// The definition specifying the cards and flow of the generated Q App.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppDefinitionInput AppDefinition { get; set; }

        /// <summary>
        /// Checks to see if the AppDefinition property is set.
        /// </summary>
        internal bool IsSetAppDefinition() => this.AppDefinition != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the generated Q App definition.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the generated Q App definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
