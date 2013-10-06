/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains an optional comment about your hosted zone. If you don't want to specify a comment, you can omit the
    /// <c>HostedZoneConfig</c> and <c>Comment</c> elements from the XML document.</para>
    /// </summary>
    public class HostedZoneConfig
    {
        
        private string comment;

        /// <summary>
        /// An optional comment about your hosted zone. If you don't want to specify a comment, you can omit the <c>HostedZoneConfig</c> and
        /// <c>Comment</c> elements from the XML document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HostedZoneConfig WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
    }
}
