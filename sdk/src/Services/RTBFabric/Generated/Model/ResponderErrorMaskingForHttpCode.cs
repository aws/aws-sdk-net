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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the masking for HTTP error codes.
    /// </summary>
    public partial class ResponderErrorMaskingForHttpCode
    {
        private ResponderErrorMaskingAction _action;
        private string _httpCode;
        private List<string> _loggingTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _responseLoggingPercentage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the error..
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponderErrorMaskingAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// The HTTP error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=7)]
        public string HttpCode
        {
            get { return this._httpCode; }
            set { this._httpCode = value; }
        }

        // Check to see if HttpCode property is set
        internal bool IsSetHttpCode()
        {
            return this._httpCode != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingTypes. 
        /// <para>
        /// The error log type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> LoggingTypes
        {
            get { return this._loggingTypes; }
            set { this._loggingTypes = value; }
        }

        // Check to see if LoggingTypes property is set
        internal bool IsSetLoggingTypes()
        {
            return this._loggingTypes != null && (this._loggingTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseLoggingPercentage. 
        /// <para>
        /// The percentage of response logging.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float ResponseLoggingPercentage
        {
            get { return this._responseLoggingPercentage.GetValueOrDefault(); }
            set { this._responseLoggingPercentage = value; }
        }

        // Check to see if ResponseLoggingPercentage property is set
        internal bool IsSetResponseLoggingPercentage()
        {
            return this._responseLoggingPercentage.HasValue; 
        }

    }
}