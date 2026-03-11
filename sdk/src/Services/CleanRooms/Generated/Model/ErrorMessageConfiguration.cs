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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A structure that defines the level of detail included in error messages returned by
    /// PySpark jobs. This configuration allows you to control the verbosity of error messages
    /// to help with troubleshooting PySpark jobs while maintaining appropriate security controls.
    /// </summary>
    public partial class ErrorMessageConfiguration
    {
        private ErrorMessageType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The level of detail for error messages returned by the PySpark job. When set to DETAILED,
        /// error messages include more information to help troubleshoot issues with your PySpark
        /// job.
        /// </para>
        ///  
        /// <para>
        /// Because this setting may expose sensitive data, it is recommended for development
        /// and testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ErrorMessageType Type
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