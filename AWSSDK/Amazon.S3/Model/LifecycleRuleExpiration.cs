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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Defines the length of time before objects expire
    /// </summary>
    public class LifecycleRuleExpiration
    {
        private int days;
        private DateTime date;

        /// <summary>
        /// The number of days before expiry.
        /// Required if the Date property is not set.
        /// </summary>
        public int Days
        {
            get { return this.days; }
            set { this.days = value; }
        }

        /// <summary>
        /// Gets and sets the date till expiry.
        /// Required if the Days property is not set.
        /// </summary>
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
    }
    }
}
