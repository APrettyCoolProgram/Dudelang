```markdown
# Installing Dudelang

This guide explains how to set up the Dudelang environment on your system.

## Prerequisites
- Node.js 16+ or Python 3.8+
- Git

## Quick Installation
For most users, we recommend using npm:

```bash
npm install -g dudelang-cli
```

### Alternative: From Source
If you want to contribute or need the latest features:

1. Clone the repository:
```bash
git clone https://github.com/APCP/Dudelang.git
```
2. Install dependencies:
```bash
cd Dudelang
npm install
```
3. Build and install locally:
```bash
npm run build && npm link
```

## Verification
After installation, verify by running:
```bash
dude --version
```
You should see the installed version number.
