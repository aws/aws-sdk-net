/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Inspector rules package.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>DescribeRulesPackage</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class RulesPackage
    {
        private LocalizedText _description;
        private string _provider;
        private string _rulesPackageArn;
        private string _rulesPackageName;
        private string _version;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the rules package.
        /// </para>
        /// </summary>
        public LocalizedText Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the rules package.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArn. 
        /// <para>
        ///  The ARN of the rules package.
        /// </para>
        /// </summary>
        public string RulesPackageArn
        {
            get { return this._rulesPackageArn; }
            set { this._rulesPackageArn = value; }
        }

        // Check to see if RulesPackageArn property is set
        internal bool IsSetRulesPackageArn()
        {
            return this._rulesPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageName. 
        /// <para>
        /// The name of the rules package.
        /// </para>
        /// </summary>
        public string RulesPackageName
        {
            get { return this._rulesPackageName; }
            set { this._rulesPackageName = value; }
        }

        // Check to see if RulesPackageName property is set
        internal bool IsSetRulesPackageName()
        {
            return this._rulesPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version id of the rules package.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}