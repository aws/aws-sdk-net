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
 *  API Version: 2010-11-15
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Amazon.EC2.Model;
using Amazon.Util;
using System.Globalization;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods used for setting up a VPC.
    /// </summary>
    public static partial class VPCUtilities
    {
        /// <summary>
        /// A callback delegate used to get progress messages as the VPC environment is being created.
        /// </summary>
        public delegate void Progress(string message);

        private static void WaitTillTrue(Func<bool> func)
        {
            for(int i = 0; i < 40; i++)
            {
                try
                {
                    if (func())
                        return;
                }
                catch { }
                AWSSDKUtils.Sleep(1000);
            }
        }

        private static void WriteProgress(Progress callback, string message, params string[] args)
        {
            if (callback == null)
                return;

            callback(string.Format(CultureInfo.InvariantCulture, message, args));
        }
    }
}
