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
    /// Container for the parameters to the UpdateThemeAlias operation.
    /// Updates an alias of a theme.
    /// </summary>
    public partial class UpdateThemeAliasRequest : AmazonQuickSightRequest
    {
        private string _aliasName;
        private string _awsAccountId;
        private string _themeId;
        private long? _themeVersionNumber;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the theme alias that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the theme alias that you're
        /// updating.
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
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// The ID for the theme.
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
        /// Gets and sets the property ThemeVersionNumber. 
        /// <para>
        /// The version number of the theme that the alias should reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long ThemeVersionNumber
        {
            get { return this._themeVersionNumber.GetValueOrDefault(); }
            set { this._themeVersionNumber = value; }
        }

        // Check to see if ThemeVersionNumber property is set
        internal bool IsSetThemeVersionNumber()
        {
            return this._themeVersionNumber.HasValue; 
        }

    }
}