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
    /// Container for the parameters to the UpdateTheme operation. Updates a theme.
    /// </summary>
    public partial class UpdateThemeRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the theme that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property BaseThemeId. 
        /// <para>
        /// The theme ID, defined by Amazon Quick Sight, that a custom theme inherits from. All
        /// themes initially inherit from a default Quick Sight theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string BaseThemeId { get; set; }

        /// <summary>
        /// Checks to see if the BaseThemeId property is set.
        /// </summary>
        internal bool IsSetBaseThemeId() => this.BaseThemeId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The theme configuration, which contains the theme display properties.
        /// </para>
        /// </summary>
        public ThemeConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// The ID for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Checks to see if the ThemeId property is set.
        /// </summary>
        internal bool IsSetThemeId() => this.ThemeId != null;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description of the theme version that you're updating Every time that you call <c>UpdateTheme</c>,
        /// you create a new version of the theme. Each version of the theme maintains a description
        /// of the version in <c>VersionDescription</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;
    }
}
