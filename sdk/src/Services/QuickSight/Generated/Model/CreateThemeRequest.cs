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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTheme operation.
    /// Creates a theme.
    /// 
    ///  
    /// <para>
    /// A <i>theme</i> is set of configuration options for color and layout. Themes apply
    /// to analyses and dashboards. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/themes-in-quicksight.html">Using
    /// Themes in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateThemeRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _baseThemeId;
        private ThemeConfiguration _configuration;
        private string _name;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private List<Tag> _tags = new List<Tag>();
        private string _themeId;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to store the new theme. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property BaseThemeId. 
        /// <para>
        /// The ID of the theme that a custom theme will inherit from. All themes inherit from
        /// one of the starting themes defined by Amazon QuickSight. For a list of the starting
        /// themes, use <code>ListThemes</code> or choose <b>Themes</b> from within an analysis.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string BaseThemeId
        {
            get { return this._baseThemeId; }
            set { this._baseThemeId = value; }
        }

        // Check to see if BaseThemeId property is set
        internal bool IsSetBaseThemeId()
        {
            return this._baseThemeId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The theme configuration, which contains the theme display properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThemeConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A valid grouping of resource permissions to apply to the new theme. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs for the resource tag or tags that you want to add to
        /// the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// An ID for the theme that you want to create. The theme ID is unique per Amazon Web
        /// Services Region in each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ThemeId
        {
            get { return this._themeId; }
            set { this._themeId = value; }
        }

        // Check to see if ThemeId property is set
        internal bool IsSetThemeId()
        {
            return this._themeId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description of the first version of the theme that you're creating. Every time <code>UpdateTheme</code>
        /// is called, a new version is created. Each version of the theme has a description of
        /// the version in the <code>VersionDescription</code> field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}