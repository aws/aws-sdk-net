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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition of the brand.
    /// </summary>
    public partial class BrandDefinition
    {
        /// <summary>
        /// Gets and sets the property ApplicationTheme. 
        /// <para>
        /// The application theme of the brand.
        /// </para>
        /// </summary>
        public ApplicationTheme ApplicationTheme { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationTheme property is set.
        /// </summary>
        internal bool IsSetApplicationTheme() => this.ApplicationTheme != null;

        /// <summary>
        /// Gets and sets the property BrandName. 
        /// <para>
        /// The name of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string BrandName { get; set; }

        /// <summary>
        /// Checks to see if the BrandName property is set.
        /// </summary>
        internal bool IsSetBrandName() => this.BrandName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LogoConfiguration. 
        /// <para>
        /// The logo configuration of the brand.
        /// </para>
        /// </summary>
        public LogoConfiguration LogoConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogoConfiguration property is set.
        /// </summary>
        internal bool IsSetLogoConfiguration() => this.LogoConfiguration != null;
    }
}
