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
 *
 */

using System;
using System.Collections.Specialized;
using System.ComponentModel;

using Amazon.Util;

namespace Amazon
{
    /// <summary>
    /// Configuration options that apply to the entire SDK.
    /// </summary>
    public static partial class AWSConfigs
    {
        public static string GetConfig(string name)
        {
            return null;
        }

        internal static bool XmlSectionExists(string sectionName)
        {
            return false;
        }
    }
}
