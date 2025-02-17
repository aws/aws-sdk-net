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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// An object that describes the implementation type for a control.
    /// 
    ///  
    /// <para>
    /// Our <c>ImplementationDetails</c> <c>Type</c> format has three required segments:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>SERVICE-PROVIDER::SERVICE-NAME::RESOURCE-NAME</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, <c>AWS::Config::ConfigRule</c> <b>or</b> <c>AWS::SecurityHub::SecurityControl</c>
    /// resources have the format with three required segments.
    /// </para>
    ///  
    /// <para>
    /// Our <c>ImplementationDetails</c> <c>Type</c> format has an optional fourth segment,
    /// which is present for applicable implementation types. The format is as follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>SERVICE-PROVIDER::SERVICE-NAME::RESOURCE-NAME::RESOURCE-TYPE-DESCRIPTION</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, <c>AWS::Organizations::Policy::SERVICE_CONTROL_POLICY</c> <b>or</b> <c>AWS::CloudFormation::Type::HOOK</c>
    /// have the format with four segments.
    /// </para>
    ///  
    /// <para>
    /// Although the format is similar, the values for the <c>Type</c> field do not match
    /// any Amazon Web Services CloudFormation values.
    /// </para>
    /// </summary>
    public partial class ImplementationDetails
    {
        private string _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A string that describes a control's implementation type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=2048)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}