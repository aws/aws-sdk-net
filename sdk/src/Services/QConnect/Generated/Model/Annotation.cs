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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// An annotation that provides additional context or metadata.
    /// </summary>
    public partial class Annotation
    {
        private bool? _destructiveHint;
        private string _title;

        /// <summary>
        /// Gets and sets the property DestructiveHint. 
        /// <para>
        /// A hint indicating that the annotation contains potentially destructive content.
        /// </para>
        /// </summary>
        public bool? DestructiveHint
        {
            get { return this._destructiveHint; }
            set { this._destructiveHint = value; }
        }

        // Check to see if DestructiveHint property is set
        internal bool IsSetDestructiveHint()
        {
            return this._destructiveHint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the annotation.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}