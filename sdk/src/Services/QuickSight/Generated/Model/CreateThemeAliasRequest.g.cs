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
    /// Container for the parameters to the CreateThemeAlias operation. Creates a theme alias
    /// for a theme.
    /// </summary>
    public partial class CreateThemeAliasRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name that you want to give to the theme alias that you are creating. The alias
        /// name can't begin with a <c>$</c>. Alias names that start with <c>$</c> are reserved
        /// by Amazon Quick Sight. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the theme for the new theme
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// An ID for the theme alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Checks to see if the ThemeId property is set.
        /// </summary>
        internal bool IsSetThemeId() => this.ThemeId != null;

        /// <summary>
        /// Gets and sets the property ThemeVersionNumber. 
        /// <para>
        /// The version number of the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? ThemeVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ThemeVersionNumber property is set.
        /// </summary>
        internal bool IsSetThemeVersionNumber() => this.ThemeVersionNumber.HasValue;
    }
}
