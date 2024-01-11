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

using System.Text;

namespace LambdaBenchmarks
{
    public static class Utilities
    {
        public static readonly long MegSize = 1048576;
        public static readonly long KBSize = 1024;

        public static byte[] GenerateTestBytes(long size)
        {
            byte[] data = new byte[size];
            Random rng = new Random();
            rng.NextBytes(data);

            return data;
        }

        public static string GenerateTestString(long size)
        {
            StringBuilder sb = new StringBuilder();
            for (long i = 0; i < size; i++)
            {
                char c = (char)('a' + (i % 26));
                sb.Append(c);
            }
            string contents = sb.ToString();
            return contents;
        }
    }
}
