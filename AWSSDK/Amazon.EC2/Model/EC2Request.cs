/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Base class for EC2 operation requests.
    /// </summary>
    public abstract class EC2Request
    {
        private bool? isDryRunField;

        /// <summary>
        /// Flag that signals that this request should be a dry-run.
        /// The service call then checks whether you have the required permissions for the
        /// action, without actually making the request.
        /// </summary>
        internal bool IsDryRun
        {
            get { return this.isDryRunField.GetValueOrDefault(); }
            set { this.isDryRunField = value; }
        }

        /// <summary>
        /// Checks if IsDryRun property is set
        /// </summary>
        /// <returns>true if IsDryRun property is set</returns>
        internal bool IsSetIsDryRun()
        {
            return isDryRunField.HasValue;
        }

    }
}
