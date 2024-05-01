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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The template alias.
    /// </summary>
    public partial class TemplateAlias
    {
        private string _aliasName;
        private string _arn;
        private long? _templateVersionNumber;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The display name of the template alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template alias.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersionNumber. 
        /// <para>
        /// The version number of the template alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? TemplateVersionNumber
        {
            get { return this._templateVersionNumber; }
            set { this._templateVersionNumber = value; }
        }

        // Check to see if TemplateVersionNumber property is set
        internal bool IsSetTemplateVersionNumber()
        {
            return this._templateVersionNumber.HasValue; 
        }

    }
}