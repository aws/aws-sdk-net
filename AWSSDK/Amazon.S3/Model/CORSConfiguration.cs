/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A collection of up to 100 cross-origin resource sharing (CORS) rules.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class CORSConfiguration
    {
        private List<CORSRule> rules;

        /// <summary>
        /// The collection of rules in this configuration.
        /// </summary>
        public List<CORSRule> Rules
        {
            get
            {
                if (this.rules == null)
                    this.rules = new List<CORSRule>();
                return this.rules;
            }
            set { this.rules = value; }
        }

        /// <summary>
        /// Sets the collecton of rules in this configuration.
        /// </summary>
        /// <param name="args">Rules property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CORSConfiguration WithRules(params CORSRule[] args)
        {
            foreach (CORSRule arg in args)
            {
                Rules.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if Rules property is set.
        /// </summary>
        /// <returns>true if Rules property is set.</returns>
        internal bool IsSetRules()
        {
            return (this.Rules.Count > 0);
        }

    }
}
