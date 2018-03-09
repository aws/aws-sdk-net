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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Attribute associated with a resource.
    /// 
    ///  
    /// <para>
    /// Note the corresponding format required per type listed below:
    /// </para>
    ///  <dl> <dt>IPV4</dt> <dd> 
    /// <para>
    ///  <code>x.x.x.x</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>where x is an integer in the range [0,255]</i> 
    /// </para>
    ///  </dd> <dt>IPV6</dt> <dd> 
    /// <para>
    ///  <code>y : y : y : y : y : y : y : y</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>where y is a hexadecimal between 0 and FFFF. [0, FFFF]</i> 
    /// </para>
    ///  </dd> <dt>MAC_ADDRESS</dt> <dd> 
    /// <para>
    ///  <code>^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$</code> 
    /// </para>
    ///  </dd> <dt>FQDN</dt> <dd> 
    /// <para>
    ///  <code>^[^&lt;&gt;{}\\\\/?,=\\p{Cntrl}]{1,256}$</code> 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ResourceAttribute
    {
        private ResourceAttributeType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of resource.
        /// </para>
        /// </summary>
        public ResourceAttributeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value of the resource type.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}