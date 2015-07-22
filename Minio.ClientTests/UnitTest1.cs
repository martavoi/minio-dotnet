﻿/*
 * Minimal Object Storage Library, (C) 2015 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using NUnit.Framework;
using Minio.Client;

namespace Minio.ClientTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestWithUrl()
        {
            Client.GetClient("http://localhost:9000");
        }

        [Test]
        public void TestWithoutPort()
        {
            Client.GetClient("http://localhost:9000");
        }

        [Test]
        public void TestWithTrailingSlash()
        {
            Client.GetClient("http://localhost:9000/");
        }

        [Test]
        [ExpectedException(typeof(UriFormatException))]
        public void TestUrlFailsWithMalformedScheme()
        {
            Client.GetClient("htp://localhost:9000");
        }

        [Test]
        [ExpectedException(typeof(UriFormatException))]
        public void TestUrlFailsWithPath()
        {
            Client.GetClient("http://localhost:9000/foo");
        }

        [Test]
        [ExpectedException(typeof(UriFormatException))]
        public void TestUrlFailsWithQuery()
        {
            Client.GetClient("http://localhost:9000/?foo=bar");
        }
    }
}
